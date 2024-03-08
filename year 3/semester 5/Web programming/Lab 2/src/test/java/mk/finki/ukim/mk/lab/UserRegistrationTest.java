package mk.finki.ukim.mk.lab;

import mk.finki.ukim.mk.lab.model.User;
import mk.finki.ukim.mk.lab.model.exceptions.InvalidArgumentsException;
import mk.finki.ukim.mk.lab.repository.UserRepository;
import mk.finki.ukim.mk.lab.service.AuthService;
import mk.finki.ukim.mk.lab.service.impl.AuthServiceImpl;
import org.junit.Assert;
import org.junit.Before;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.MockitoAnnotations;
import org.mockito.junit.MockitoJUnitRunner;

import java.time.LocalDate;

@RunWith(MockitoJUnitRunner.class)
public class UserRegistrationTest {


    @Mock
    private UserRepository userRepository;

    @Mock
    private AuthService service;


    @Before
    public void init() {
        MockitoAnnotations.initMocks(this);
        User user = new User("username", "name", "surname", "password", null);
        Mockito.when(this.userRepository.save(Mockito.any(User.class))).thenReturn(user);
        this.service = Mockito.spy(new AuthServiceImpl(this.userRepository));
    }

    @Test
    public void testSuccessRegister() {
        User user = this.service.register("username", "password", "name", "surname", null);

        Mockito.verify(this.service).register("username", "password", "name", "surname", null);


        Assert.assertNotNull("User is null", user);
        Assert.assertEquals("name do not mach", "name", user.getName());
        Assert.assertEquals("date of birth do not mach", null, user.getDateOfBirth());
        Assert.assertEquals("surname do not mach", "surname", user.getSurname());
        Assert.assertEquals("password do not mach", "password", user.getPassword());
        Assert.assertEquals("username do not mach", "username", user.getUsername());
    }


    @Test
    public void testNullUsername() {
        Assert.assertThrows("InvalidArgumentException expected",
                InvalidArgumentsException.class,
                () -> this.service.register(null, "password", "name", "surname", null));
        Mockito.verify(this.service).register(null, "password", "name", "surname", null);
    }

    @Test
    public void testEmptyUsername() {
        String username = "";
        Assert.assertThrows("InvalidArgumentException expected",
                InvalidArgumentsException.class,
                () -> this.service.register(username, "password", "name", "surname", null));
        Mockito.verify(this.service).register(username, "password", "name", "surname", null);
    }

    @Test
    public void testEmptyPassword() {
        String username = "username";
        String password = "";
        Assert.assertThrows("InvalidArgumentException expected",
                InvalidArgumentsException.class,
                () -> this.service.register(username, password, "name", "surname", null));
        Mockito.verify(this.service).register(username, password, "name", "surname", null);
    }

    @Test
    public void testNullPassword() {
        String username = "username";
        String password = null;
        Assert.assertThrows("InvalidArgumentException expected",
                InvalidArgumentsException.class,
                () -> this.service.register(username, password,  "name", "surename",null));
        Mockito.verify(this.service).register(username, password,  "name", "surename",null);
    }
}

