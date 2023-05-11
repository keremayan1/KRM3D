package com.KRM3D.adultquestiontitleservice.repositories;

import com.KRM3D.adultquestiontitleservice.entities.AdultQuestionTitle;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface AdultQuestionTitleRepository extends MongoRepository<AdultQuestionTitle,String> {
}
