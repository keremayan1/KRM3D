package com.KRM3D.adultfamilyservice.services.Siblings.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

@Data
public class UpdatedSiblingsDto {
    @Id
    private String get_id;

    private String adultId;
    @NotNull(message = "İsim Alanı Boş Geçilemez!")
    @NotBlank(message = "İsim Boş Geçilemez!")
    private String firstName;

    @NotNull(message = "Soyad Alanı Boş Geçilemez!")
    @NotBlank(message = "Soyad Alanı Boş Geçilemez!")
    private String lastName;

    @NotNull
    @NotBlank
    private String educationStatusId;

    @NotNull
    @NotBlank
    private String genderId;

    @NotNull(message = "Yaş Alanı Boş Geçilemez!")
    @NotBlank(message = "Yaş Alanı Boş Geçilemez!")
    private String age;
    @NotNull(message = "Meslek Boş Geçilemez!")
    @NotBlank(message = "Meslek Alanı Boş Geçilemez!")
    private String job;

    @NotNull(message = "Telefon Numarası Alanı Boş Geçilemez!")
    @NotBlank(message = "Telefon Numarası Alanı Boş Geçilemez!")
    private String telephoneNumber;

    @NotNull(message = "Kaç Tane Çocuğu Var Alanı Boş Geçilemez!")
    @NotBlank(message = "Kaç Tane Çocuğu Var Alanı Boş Geçilemez!")
    private String howManyChildHave;

    @NotNull(message = "Kiminle Yaşadığı Alanı Boş Geçilemez!")
    @NotBlank(message = "Kiminle Yaşadığı  Alanı Boş Geçilemez!")
    private String isLiveWith;
}
