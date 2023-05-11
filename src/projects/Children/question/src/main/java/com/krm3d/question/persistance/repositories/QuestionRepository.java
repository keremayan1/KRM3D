package com.krm3d.question.persistance.repositories;

import com.krm3d.question.domain.entities.Question;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface QuestionRepository extends MongoRepository<Question,String> {
}
