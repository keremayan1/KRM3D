package com.KRM3D.adultservice.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.cglib.core.Local;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.index.Indexed;

import java.sql.Date;
import java.time.LocalDate;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class Adult {
    @Id
    private String _id;
    private String genderId;
    private String educationStatusId;
    private String marriedStatusId;
    private String nationalId;
    private String firstName;
    private String lastName;
    private LocalDate dateOfBirth;
    private String ethnicName;
    private String religionName;
    private String job;
    private String isLiveWith;
    private String didSheHeComeWith;
    private String personComesFromHere;
    private String reasonOfApplication;
}
