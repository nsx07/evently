using System.Text.Json.Serialization;

namespace Evently.Contracts.Common;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SubscriptionType
{
    Basic,
    Pro,
}