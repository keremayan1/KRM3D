package com.KRM3D.adultquestionservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

@Data
public class CreatedAdultQuestionDto {
    @NotNull
    @NotBlank
    private String questionTitleId;

    @NotNull(message = "Soru ismi boş olamaz!")
    @NotBlank(message = "Soru ismi boş olamaz!")
    private String questionName;
}
