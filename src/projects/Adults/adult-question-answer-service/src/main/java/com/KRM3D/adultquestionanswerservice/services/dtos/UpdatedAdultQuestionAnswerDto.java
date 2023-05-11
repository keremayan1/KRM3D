package com.KRM3D.adultquestionanswerservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class UpdatedAdultQuestionAnswerDto {
    @Id
    private String get_id;
    private String questionId;
    private String answer;
}
