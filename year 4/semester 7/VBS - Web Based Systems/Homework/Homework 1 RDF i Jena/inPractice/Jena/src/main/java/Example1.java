import org.apache.jena.rdf.model.*;
import org.apache.jena.sparql.vocabulary.FOAF;
import org.apache.jena.vocabulary.VCARD;

public class Example1 {
    public static void main(String[] args) {
        Model model = ModelFactory.createDefaultModel();

        String instagramId = "https://www.instagram.com/andrejbardakoski/";

        Resource andrej = model.createResource(instagramId);
        andrej.addProperty(VCARD.FN, "Andrej Bardakoski");
        andrej.addProperty(VCARD.NICKNAME, "Jony");
        andrej.addProperty(VCARD.NICKNAME, "Bardak");
        andrej.addProperty(VCARD.NICKNAME, "Sashko");
        andrej.addProperty(VCARD.BDAY, "20.10.2001");
        andrej.addProperty(VCARD.N, model.createResource()
                .addProperty(VCARD.Given, "Andrej")
                .addProperty(VCARD.Family, "Bardakoski"));
        andrej.addProperty(VCARD.ADR, model.createResource()
                .addProperty(VCARD.Country, "Macedonia")
                .addProperty(VCARD.Locality, "Skopje")
                .addProperty(VCARD.Pcode, "1000")
                .addProperty(VCARD.Street, "Krume Kepeski"));
        andrej.addProperty(FOAF.age, "22");
        andrej.addProperty(FOAF.accountName, "andrejbardakoski");

        printModelListStatements(model);
        System.out.println("------------------------------------------------------------------------------");
        System.out.println("Printing with model.print(), in RDF/XML.");
        model.write(System.out);
        System.out.println("------------------------------------------------------------------------------");
        System.out.println("Printing with model.print(), in Pretty RDF/XML");
        model.write(System.out, "RDF/XML-ABBREV");
        System.out.println("------------------------------------------------------------------------------");
        System.out.println("Printing with model.print(), in Turtle");
        model.write(System.out, "TURTLE");
        System.out.println("------------------------------------------------------------------------------");
        System.out.println("Printing with model.print(), in N-Triples");
        model.write(System.out, "N-TRIPLES");

    }

    public static void printModelListStatements(Model model) {
        System.out.println("Printing with model.listStatements():");
        StmtIterator iterator = model.listStatements();

        while (iterator.hasNext()) {
            Statement statement = iterator.nextStatement();
            Resource subject = statement.getSubject();
            Property predicate = statement.getPredicate();
            RDFNode object = statement.getObject();

            System.out.print(subject.toString());
            System.out.print(" - " + predicate.toString() + " - ");
            if (object instanceof Resource) {
                System.out.print(object.toString());
            } else {
                // object is a literal
                System.out.print(" \"" + object.toString() + "\"");
            }
            System.out.println();
        }
    }
}
