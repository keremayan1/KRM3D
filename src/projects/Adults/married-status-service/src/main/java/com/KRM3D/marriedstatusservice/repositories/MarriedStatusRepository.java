package com.KRM3D.marriedstatusservice.repositories;

import com.KRM3D.marriedstatusservice.entities.MarriedStatus;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface MarriedStatusRepository extends MongoRepository<MarriedStatus,String> {
}
