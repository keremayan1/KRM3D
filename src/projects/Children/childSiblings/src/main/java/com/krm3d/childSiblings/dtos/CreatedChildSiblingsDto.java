package com.krm3d.childSiblings.dtos;

import lombok.Data;

@Data
public class CreatedChildSiblingsDto {
    private String childId;
    private String genderId;
    private String firstName;
    private String lastName;
    private int age;
    private String educationStatusId;
    private String job;
}
