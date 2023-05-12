package com.KRM3D.adultservice.repositories;

import com.KRM3D.adultservice.entities.Adult;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;



@EnableMongoRepositories
public interface AdultRepository extends MongoRepository<Adult,String> {
    Adult findByNationalId(String nationalId);
}
