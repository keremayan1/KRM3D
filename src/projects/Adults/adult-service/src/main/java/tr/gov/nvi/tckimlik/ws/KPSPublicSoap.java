
package tr.gov.nvi.tckimlik.ws;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.3.3
 * Generated source version: 2.2
 * 
 */
@WebService(name = "KPSPublicSoap", targetNamespace = "http://tckimlik.nvi.gov.tr/WS")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface KPSPublicSoap {


    /**
     * 
     * @param dogumYili
     * @param ad
     * @param tcKimlikNo
     * @param soyad
     * @return
     *     returns boolean
     */
    @WebMethod(operationName = "TCKimlikNoDogrula", action = "http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula")
    @WebResult(name = "TCKimlikNoDogrulaResult", targetNamespace = "http://tckimlik.nvi.gov.tr/WS")
    @RequestWrapper(localName = "TCKimlikNoDogrula", targetNamespace = "http://tckimlik.nvi.gov.tr/WS", className = "tr.gov.nvi.tckimlik.ws.TCKimlikNoDogrula")
    @ResponseWrapper(localName = "TCKimlikNoDogrulaResponse", targetNamespace = "http://tckimlik.nvi.gov.tr/WS", className = "tr.gov.nvi.tckimlik.ws.TCKimlikNoDogrulaResponse")
    public boolean tcKimlikNoDogrula(
        @WebParam(name = "TCKimlikNo", targetNamespace = "http://tckimlik.nvi.gov.tr/WS")
        long tcKimlikNo,
        @WebParam(name = "Ad", targetNamespace = "http://tckimlik.nvi.gov.tr/WS")
        String ad,
        @WebParam(name = "Soyad", targetNamespace = "http://tckimlik.nvi.gov.tr/WS")
        String soyad,
        @WebParam(name = "DogumYili", targetNamespace = "http://tckimlik.nvi.gov.tr/WS")
        int dogumYili);

}
