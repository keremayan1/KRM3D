package com.KRM3D.adultfamilyservice.repositories;

import com.KRM3D.adultfamilyservice.entities.Mother;
import com.KRM3D.adultfamilyservice.entities.Siblings;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface MotherRepository extends MongoRepository<Mother, String> {
}
