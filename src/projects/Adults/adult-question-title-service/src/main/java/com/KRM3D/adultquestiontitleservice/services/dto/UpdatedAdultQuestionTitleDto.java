package com.KRM3D.adultquestiontitleservice.services.dto;

import lombok.Data;
import org.springframework.data.annotation.Id;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

@Data
public class UpdatedAdultQuestionTitleDto {
    @Id
    private String get_id;

    @NotNull(message = "Soru Başlığı Alanı Boş Olamaz!")
    @NotBlank(message = "Soru Başlığı Alanı Boş Olamaz!")
    private String questionTitleName;
}
