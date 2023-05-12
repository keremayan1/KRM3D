package com.KRM3D.adultfamilyservice.services.Mother.rules;

import com.KRM3D.adultfamilyservice.entities.Father;
import com.KRM3D.adultfamilyservice.entities.Mother;
import com.KRM3D.adultfamilyservice.repositories.FatherRepository;
import com.KRM3D.adultfamilyservice.repositories.MotherRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MotherBusinessRules {
    private MotherRepository motherRepository;

    @Autowired
    public MotherBusinessRules(MotherRepository motherRepository) {
        this.motherRepository = motherRepository;
    }
    public  void SetToUpper(Mother mother){
        mother.setFirstName(mother.getFirstName().toUpperCase());
        mother.setLastName(mother.getLastName().toUpperCase());
        mother.setJob(mother.getJob().toUpperCase());
        mother.setHowManyChildHave(mother.getHowManyChildHave().toUpperCase());
        mother.setIsLiveWith(mother.getIsLiveWith().toUpperCase());
    }
    public  void SetTrim(Mother mother){
        mother.setFirstName(mother.getFirstName().trim());
        mother.setLastName(mother.getLastName().trim());
        mother.setJob(mother.getJob().trim());
        mother.setHowManyChildHave(mother.getHowManyChildHave().trim());
        mother.setIsLiveWith(mother.getIsLiveWith().trim());
    }
}
