package com.KRM3D.adultquestionanswerservice.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class AdultQuestionAnswer {
    @Id
    private String _id;
    private String questionId;
    private String questionAnswer;
}
