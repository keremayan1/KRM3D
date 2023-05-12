package com.KRM3D.adultfamilyservice.services.Siblings.rules;

import com.KRM3D.adultfamilyservice.entities.Mother;
import com.KRM3D.adultfamilyservice.entities.Siblings;
import com.KRM3D.adultfamilyservice.repositories.SiblingsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class SiblingsBusinessRules {
   private SiblingsRepository siblingsRepository;
    @Autowired
    public SiblingsBusinessRules(SiblingsRepository siblingsRepository) {
        this.siblingsRepository = siblingsRepository;
    }
    public  void SetToUpper(Siblings siblings){
        siblings.setFirstName(siblings.getFirstName().toUpperCase());
        siblings.setLastName(siblings.getLastName().toUpperCase());
        siblings.setJob(siblings.getJob().toUpperCase());
        siblings.setHowManyChildHave(siblings.getHowManyChildHave().toUpperCase());
        siblings.setIsLiveWith(siblings.getIsLiveWith().toUpperCase());
    }
    public  void SetTrim(Siblings siblings){
        siblings.setFirstName(siblings.getFirstName().trim());
        siblings.setLastName(siblings.getLastName().trim());
        siblings.setJob(siblings.getJob().trim());
        siblings.setHowManyChildHave(siblings.getHowManyChildHave().trim());
        siblings.setIsLiveWith(siblings.getIsLiveWith().trim());
    }
}
