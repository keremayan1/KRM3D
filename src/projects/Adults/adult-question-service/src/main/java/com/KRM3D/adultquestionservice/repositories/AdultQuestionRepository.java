package com.KRM3D.adultquestionservice.repositories;

import com.KRM3D.adultquestionservice.entities.AdultQuestion;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface AdultQuestionRepository extends MongoRepository<AdultQuestion,String> {
}
