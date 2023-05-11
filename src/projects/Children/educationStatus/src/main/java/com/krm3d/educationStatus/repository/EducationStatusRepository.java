package com.krm3d.educationStatus.repository;


import com.krm3d.educationStatus.entity.EducationStatus;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@EnableMongoRepositories
public interface EducationStatusRepository extends MongoRepository<EducationStatus,String> {
}
