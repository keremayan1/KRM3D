package com.KRM3D.adultservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;
import java.time.LocalDate;
@Data
public class CreatedAdultDto {

    private String genderId;
    private String educationStatusId;
    private String marriedStatusId;
    @NotBlank
    @NotNull
    private String nationalId;

    @NotBlank
    @NotNull
    private String firstName;

    @NotBlank
    @NotNull
    private String lastName;


    private LocalDate dateOfBirth;

    @NotBlank
    @NotNull
    private String ethnicName;

    @NotBlank
    @NotNull
    private String religionName;

    @NotBlank
    @NotNull
    private String job;

    @NotBlank
    @NotNull
    private String isLiveWith;

    @NotBlank
    @NotNull
    private String didSheHeComeWith;

    @NotBlank
    @NotNull
    private String personComesFromHere;

    @NotBlank
    @NotNull
    private String reasonOfApplication;
}
