package com.krm3d.childSiblings.rules;


import com.krm3d.childSiblings.entities.ChildSiblings;
import com.krm3d.childSiblings.repositories.ChildSiblingsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ChildSiblingsBusinessRules {
    private ChildSiblingsRepository childSiblingsRepository;
@Autowired
    public ChildSiblingsBusinessRules(ChildSiblingsRepository childSiblingsRepository) {
        this.childSiblingsRepository = childSiblingsRepository;
    }
    public void ToUpper(ChildSiblings childSiblings) throws Exception {
     childSiblings.setFirstName(childSiblings.getFirstName().toUpperCase());
     childSiblings.setLastName(childSiblings.getLastName().toUpperCase());
     childSiblings.setJob(childSiblings.getJob().toUpperCase());
    }
    public void Trim(ChildSiblings childSiblings) throws Exception {
        childSiblings.setFirstName(childSiblings.getFirstName().trim());
        childSiblings.setLastName(childSiblings.getLastName().trim());
        childSiblings.setJob(childSiblings.getJob().trim());
    }
}
