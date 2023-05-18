package com.KRM3D.childsiblings.dtos;

import lombok.Data;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

@Data
public class UpdatedChildSiblingsDto {
    private String get_id;
    @NotNull
    @NotBlank
    private String childId;

    @NotNull
    @NotBlank
    private String genderId;

    @NotNull(message = "İsim Boş Olamaz!")
    @NotBlank(message = "İsim Boş Olamaz!")
    private String firstName;
    @NotNull(message = "Soy isim Boş Olamaz!")
    @NotBlank(message = " Soy isim Boş Olamaz!")
    private String lastName;

    @NotNull(message = "Yaş Boş Olamaz!")
    @NotBlank(message = "Yaş Boş Olamaz!")
    private String age;
    @NotNull
    @NotBlank
    private String educationStatusId;
    @NotNull(message = "Meslek Boş Olamaz!")
    @NotBlank(message = "Meslek Boş Olamaz!")
    private String job;
}
