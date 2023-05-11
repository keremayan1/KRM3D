package com.krm3d.question.domain.entities;

import lombok.Data;
import org.bson.BsonType;
import org.bson.codecs.pojo.annotations.BsonId;
import org.bson.codecs.pojo.annotations.BsonRepresentation;
import org.springframework.data.annotation.Id;
@Data
public class MongoDbEntity {
    @BsonId
    @BsonRepresentation(BsonType.OBJECT_ID)
    private String _id;
}
