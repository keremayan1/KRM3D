package com.KRM3D.adultfamilyservice.entities;

import com.KRM3D.adultfamilyservice.entities.abstracts.Person;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Father extends Person {
    private String telephoneNumber;
    private String howManyChildHave;
    private String isLiveWith;
}

