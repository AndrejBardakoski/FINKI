import org.apache.jena.rdf.model.*;
import org.apache.jena.vocabulary.RDFS;

import java.util.List;

public class Example3 {
    public static void main(String[] args) {
        Model model = ModelFactory.createDefaultModel();
        model.read("hifm-dataset.ttl", "TTL");

        List<String> labelNames = model.listStatements(new SimpleSelector(null, RDFS.label, (RDFNode) null))
                .mapWith(x -> x.getObject().asLiteral().toString()).toList().stream().sorted().toList();

        System.out.println("All names");
        for (String name : labelNames) {
            System.out.println(name);
        }

        String tramadolID = "http://purl.org/net/hifm/data#989649";
        Resource tramadol = model.getResource(tramadolID);
        StmtIterator tramadolStatementsItr = tramadol.listProperties();

        System.out.println("All tramadol relations");
        while (tramadolStatementsItr.hasNext()) {
            Statement statement = tramadolStatementsItr.nextStatement();
            System.out.println(statement.getObject().toString()
                    + " -> " + statement.getPredicate().toString()
                    + " -> " + statement.getObject().toString());
        }
        List<Property> tramadolRelations = tramadolStatementsItr.mapWith(Statement::getPredicate).toList();
        List<RDFNode> tramadolRelationValues = tramadolStatementsItr.mapWith(Statement::getObject).toList();

        String hifm_ont = "http://purl.org/net/hifm/ontology#";
        String similarToID = hifm_ont + "similarTo";
        tramadolStatementsItr = tramadol.listProperties(model.getProperty(similarToID));
        System.out.println("names of all tramadol similar to");
        while (tramadolStatementsItr.hasNext()) {
            String objID = tramadolStatementsItr.nextStatement().getObject().toString();
            Resource resource = model.getResource(objID);
            System.out.println(resource.getProperty(RDFS.label).getObject().toString());
        }

        String priceID = hifm_ont + "refPriceWithVAT";
        float tramadolPrice = tramadol.getProperty(model.getProperty(priceID)).getObject().asLiteral().getFloat();
        System.out.println("Tramadol price: " + tramadolPrice);

        tramadolStatementsItr = tramadol.listProperties(model.getProperty(similarToID));
        System.out.println("prices of all tramadol similar to");
        while (tramadolStatementsItr.hasNext()) {
            String objID = tramadolStatementsItr.nextStatement().getObject().toString();
            Resource resource = model.getResource(objID);
            String resourceName = resource.getProperty(RDFS.label).getObject().toString();
            float resourcePrice = resource.getProperty(model.getProperty(priceID)).getObject().asLiteral().getFloat();

            System.out.println(resourceName + " so cena: " + resourcePrice);
        }


    }
}
