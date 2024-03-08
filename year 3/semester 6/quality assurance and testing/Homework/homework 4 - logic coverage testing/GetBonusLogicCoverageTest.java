package domasna4;

import java.util.Arrays;
import java.util.Collection;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;

public class GetBonusLogicCoverageTest {

    public static Collection<Object[]> testRequirements() {
        return Arrays.asList(new Object[][]{
                {true, true, 10, true}, // Тест 1: ТТТ
                {false, true, 10, false}, // Тест2: FTT
                {false, false, 10, true}, // Тест3: FFT
                {false, false, 3, false} // Тест2: FFF
        });
    }

    @ParameterizedTest
    @MethodSource("testRequirements")
    public void testGetBonus(boolean isSenior, boolean isPartTime, int monthsInCompany, boolean expectedResult) {
        Employee employee = new Employee(isSenior, isPartTime, monthsInCompany);
        boolean result = GetBonus.getBonus(employee);
        Assertions.assertEquals(expectedResult, result, "Logic RACC coverage test");
    }

}
