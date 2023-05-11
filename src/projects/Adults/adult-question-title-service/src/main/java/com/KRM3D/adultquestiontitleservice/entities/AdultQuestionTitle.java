package com.KRM3D.adultquestiontitleservice.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class AdultQuestionTitle {
    @Id
    private String _id;
    private String questionTitleName;
}
