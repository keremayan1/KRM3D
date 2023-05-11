package com.KRM3D.adultquestionanswerservice.repositories;

import com.KRM3D.adultquestionanswerservice.entities.AdultQuestionAnswer;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface AdultQuestionAnswerRepository extends MongoRepository<AdultQuestionAnswer,String> {
}
