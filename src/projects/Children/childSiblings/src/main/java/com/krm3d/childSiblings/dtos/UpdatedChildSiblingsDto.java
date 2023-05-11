package com.krm3d.childSiblings.dtos;

import lombok.Data;

@Data
public class UpdatedChildSiblingsDto {
    private String get_id;
    private String childId;
    private String firstName;
    private String lastName;
    private int age;
    private String educationStatusId;
    private String job;
}
