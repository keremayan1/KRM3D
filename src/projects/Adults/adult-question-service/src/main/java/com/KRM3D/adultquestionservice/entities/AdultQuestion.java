package com.KRM3D.adultquestionservice.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class AdultQuestion {
    @Id
    private String _id;
    private String questionTitleId;
    private String questionName;
}
