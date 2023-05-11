package com.KRM3D.adultquestionanswerservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class CreatedAdultQuestionAnswerDto {
    private String questionId;
    private String answer;
}

