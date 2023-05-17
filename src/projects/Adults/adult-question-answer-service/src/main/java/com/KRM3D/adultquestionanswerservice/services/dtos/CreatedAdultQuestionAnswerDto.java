package com.KRM3D.adultquestionanswerservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

@Data
public class CreatedAdultQuestionAnswerDto {

    @NotBlank
    @NotNull
    private String adultId;


    @NotBlank
    @NotNull
    private String questionId;



    @NotBlank(message = "Cevap Boş Olamaz!")
    @NotNull(message = "Cevap Boş Olamaz!")
    private String answer;
}

