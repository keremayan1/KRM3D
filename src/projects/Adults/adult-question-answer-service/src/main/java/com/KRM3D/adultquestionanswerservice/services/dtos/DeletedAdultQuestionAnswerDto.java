package com.KRM3D.adultquestionanswerservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class DeletedAdultQuestionAnswerDto {
    @Id
    private String _id;
}
