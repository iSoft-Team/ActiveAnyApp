using System;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MQTTnet.Client;
using MQTTnet;
using MQTTnet.Protocol;

namespace NetCore
{
  public delegate Task MqttPayloadReceive(string data);
  internal class MQTTConfig: MetroFramework.Forms.MetroForm
  {

    private IMqttClient client;
    private MqttClientOptions clientOptions;

    public event MqttPayloadReceive OnMqttPayloadReceive;
    public event MqttPayloadReceive MQTTConnected;
    public event MqttPayloadReceive MQTTDisconnect;
    public event MqttPayloadReceive MQTTConnecting;

    //MQTT
    public async Task MQTT_Init(string addressBroker, int portBroker)
    {
      //use a unique id as client id, each time we start the application
      var clientId = Guid.NewGuid().ToString();
      var factory = new MqttFactory();
      client = factory.CreateMqttClient();
      clientOptions = new MqttClientOptionsBuilder()
          .WithTcpServer(addressBroker, portBroker) // Port is optional
          .WithClientId(clientId)
          .Build();
      client.ConnectedAsync += Client_ConnectedAsync;
      client.ConnectingAsync += Client_ConnectingAsync;
      client.DisconnectedAsync += Client_DisconnectedAsync;
      client.ApplicationMessageReceivedAsync += Client_ApplicationMessageReceivedAsync;
      await client.ConnectAsync(clientOptions, CancellationToken.None);
    }
    private Task Client_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
    {
      string ReceivedMessage = Encoding.UTF8.GetString(arg.ApplicationMessage.Payload); //get payload
      string TopicReceived = arg.ApplicationMessage.Topic; //get topic name
      OnMqttPayloadReceive?.Invoke(ReceivedMessage);
      return Task.CompletedTask;
    }

    //Disconnect
    private async Task Client_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
    {
      await Task.Delay(TimeSpan.FromSeconds(3));
      await client.ConnectAsync(clientOptions, CancellationToken.None);
      MQTTDisconnect?.Invoke(null);
      await Task.CompletedTask;
    }

    //Connecting
    private async Task Client_ConnectingAsync(MqttClientConnectingEventArgs arg)
    {
      MQTTConnecting?.Invoke(null);
      await Task.CompletedTask;
    }

    //Connected
    public async Task Client_ConnectedAsync(MqttClientConnectedEventArgs arg)
    {
      MQTTConnected?.Invoke(null);
      await Task.CompletedTask;
    }


    public async void Publish(string topic, string payload)
    {
      try
      {
        var message = new MqttApplicationMessageBuilder()
            .WithTopic(topic.Trim())
            .WithPayload(payload)
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
            .WithRetainFlag()
            .Build();
        await client.PublishAsync(message, CancellationToken.None);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error publish");
      }
    }

    public async Task Subcribe(string topic)
    {
      try
      {
        var topic_sub = new MqttTopicFilterBuilder()
            .WithTopic(topic)
            .WithAtMostOnceQoS()
            .Build();

        await client.SubscribeAsync(topic_sub);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error subcribe");
      }
    }

  }
}
