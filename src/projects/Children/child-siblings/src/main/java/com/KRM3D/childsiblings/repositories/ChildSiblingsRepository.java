package com.KRM3D.childsiblings.repositories;

import com.KRM3D.childsiblings.entities.ChildSiblings;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

import java.util.List;

@EnableMongoRepositories
public interface ChildSiblingsRepository extends MongoRepository<ChildSiblings,String> {

    ChildSiblings findByFirstName(String firstName);
}
