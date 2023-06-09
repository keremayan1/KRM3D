package com.KRM3D.adultservice.services.adapters.PersonService.Impl;

import com.KRM3D.adultservice.entities.Adult;





import com.KRM3D.adultservice.services.adapters.PersonService.MernisService;
import org.springframework.stereotype.Service;
import tr.gov.nvi.tckimlik.ws.KPSPublic;
import tr.gov.nvi.tckimlik.ws.KPSPublicSoap;


@Service

public class MernisServiceImpl implements MernisService {

    @Override
    public Boolean Verify(Adult adult) throws Exception {
        KPSPublic service = new KPSPublic();
        KPSPublicSoap kimlikService = service.getKPSPublicSoap();
        boolean sonuc = kimlikService.tcKimlikNoDogrula(Long.valueOf(adult.getNationalId()), adult.getFirstName(), adult.getLastName(), adult.getDateOfBirth().getYear());
        return  sonuc;
    }
}
