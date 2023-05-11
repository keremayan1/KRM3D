package com.KRM3D.adultquestionservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class CreatedAdultQuestionDto {
    private String questionTitleId;
    private String questionName;
}
