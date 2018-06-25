using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace MongoDB.Driver
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TDocument"></typeparam>
    public interface IFilterDefinition<TDocument>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentSerializer"></param>
        /// <param name="serializerRegistry"></param>
        /// <returns></returns>
        BsonDocument Render(IBsonSerializer<TDocument> documentSerializer, IBsonSerializerRegistry serializerRegistry);
    }
}