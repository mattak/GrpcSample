using Cysharp.Net.Http;
using Cysharp.Threading.Tasks;
using Grpc.Net.Client;
using Helloworld;
using UnityEngine;

namespace GrpcSample
{
    public class SampleRequestRunner : MonoBehaviour
    {
        private const string URL = "https://grpc-sample-mqzqvfelqa-an.a.run.app";

        private void Start()
        {
            Request();
        }

        private void Request()
        {
            using var handler = new YetAnotherHttpHandler();
            using var channel = GrpcChannel.ForAddress(URL, new GrpcChannelOptions
            {
                HttpHandler = handler,
                DisposeHttpClient = true,
            });
            var client = new Greeter.GreeterClient(channel);

            var reply = client.SayHello(new HelloRequest {Name = "UnityClient"});
            Debug.Log("Greeting: " + reply.Message);
        }
    }
}