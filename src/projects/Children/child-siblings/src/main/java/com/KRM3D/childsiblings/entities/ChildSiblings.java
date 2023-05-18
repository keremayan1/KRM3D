package com.KRM3D.childsiblings.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Document
public class ChildSiblings {
    @Id
    private String _id;
    private String childId;
    private String genderId;
    private String firstName;
    private String lastName;
    private String age;
    private String educationStatusId;
    private String job;
}
