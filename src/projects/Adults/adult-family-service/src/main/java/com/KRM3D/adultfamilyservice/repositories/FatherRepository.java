package com.KRM3D.adultfamilyservice.repositories;

import com.KRM3D.adultfamilyservice.entities.Father;
import com.KRM3D.adultfamilyservice.entities.Mother;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface FatherRepository extends MongoRepository<Father,String> {
}

