package domasna2;

import java.util.Arrays;
import java.util.Collection;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;


public class GraphCoverageFmtTest {

    public static Collection<Object[]> testPaths() {
        return Arrays.asList(new Object[][]{
                {"", 1, "\n"}, // test1: 1,2,16 avoid loop
                {"\n\n\n", 3, "\n\n \n"}, // test2: 1,2,3,5,6,9,12,13,15,2,3,5,6,9,12,14,15,2,16;
                {"X", 1, "X\n"} // test3: 1,2,3,4,9,11,15,2,16;
        });
    }

    @ParameterizedTest
    @MethodSource("testPaths")
    public void testFmtRewrap(String S, int N, String expectedResult) {
        String result = FmtRewrap.fmtRewrap(S, N);
        Assertions.assertEquals(expectedResult, result, "Data flow test");
    }

}
