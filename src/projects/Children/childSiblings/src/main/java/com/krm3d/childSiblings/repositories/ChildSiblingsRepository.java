package com.krm3d.childSiblings.repositories;

import com.krm3d.childSiblings.entities.ChildSiblings;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

import java.util.List;

@EnableMongoRepositories
public interface ChildSiblingsRepository extends MongoRepository<ChildSiblings,String> {

    ChildSiblings findByFirstName(String firstName);
}
