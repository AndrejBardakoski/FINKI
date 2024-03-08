import org.apache.jena.rdf.model.*;
import org.apache.jena.vocabulary.VCARD;

public class Example2 {
    public static void main(String[] args) {
        Model model = ModelFactory.createDefaultModel();
        model.read("example1_output_N_Triples.nt","N-TRIPLES");

        String instagramId = "https://www.instagram.com/andrejbardakoski/";

        Resource Andrej = model.getResource(instagramId);

        String formatName = Andrej.getProperty(VCARD.FN).getObject().asLiteral().toString();
        Resource name = Andrej.getProperty(VCARD.N).getObject().asResource();
        String givenName = name.getProperty(VCARD.Given).getObject().asLiteral().toString();
        String familyName = name.getProperty(VCARD.Family).getObject().asLiteral().toString();

        System.out.println("formatname: "+formatName);
        System.out.println("Given name: "+givenName);
        System.out.println("Family name: "+familyName);
    }
}
