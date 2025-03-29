using SoapCore.Extensibility;
using System.ServiceModel.Channels;
using System.Xml;

namespace soap_service.Services
{
    public class CustomFaultExceptionTransformer : IFaultExceptionTransformer
    {
        public Message ProvideFault(Exception exception, MessageVersion messageVersion, Message faultMessage, XmlNamespaceManager xmlNamespaceManager)
        {
            var fault = Message.CreateMessage(
                messageVersion,
                "http://tempuri.org/fault",
                exception.Message
            );

            return fault;
        }
    }
}
