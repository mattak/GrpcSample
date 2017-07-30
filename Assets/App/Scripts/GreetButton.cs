using System;
using Grpc.Core;
using Helloworld;
using UnityEngine;
using UnityEngine.UI;

namespace App
{
    [RequireComponent(typeof(Button))]
    public class GreetButton : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        void OnClick()
        {
            Debug.Log("Click");
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Greeter.GreeterClient(channel);
            String user = "you";

            var reply = client.SayHello(new HelloRequest { Name = user });
            Debug.Log("Greeting: " + reply.Message);
    
            channel.ShutdownAsync().Wait();
        }
    }
}