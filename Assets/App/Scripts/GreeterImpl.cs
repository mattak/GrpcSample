using System.Threading.Tasks;
using Grpc.Core;
using Helloworld;

namespace App
{
    public class GreeterImpl : Greeter.GreeterBase
    {
        public virtual Task<HelloReply> SayHello(
            HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply {Message = "Hello " + request.Name});
        }
    }
}