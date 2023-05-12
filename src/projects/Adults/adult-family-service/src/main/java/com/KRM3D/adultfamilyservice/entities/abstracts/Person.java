package com.KRM3D.adultfamilyservice.entities.abstracts;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;

@AllArgsConstructor
@NoArgsConstructor
@Data
public abstract class Person {

    @Id
    private String _id;
    private String firstName;
    private String lastName;
    private String educationStatusId;
    private String age;
    private String job;


}
