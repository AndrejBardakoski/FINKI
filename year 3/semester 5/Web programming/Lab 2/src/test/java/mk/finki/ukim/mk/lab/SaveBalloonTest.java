package mk.finki.ukim.mk.lab;

//import mk.finki.ukim.mk.lab.repository.UserRepository;

import mk.finki.ukim.mk.lab.model.Balloon;
import mk.finki.ukim.mk.lab.model.Manufacturer;
import mk.finki.ukim.mk.lab.model.exceptions.ManufacturerNotFoundException;
import mk.finki.ukim.mk.lab.repository.BalloonRepository;
import mk.finki.ukim.mk.lab.repository.ManufacturerRepository;
import mk.finki.ukim.mk.lab.service.BalloonService;
import mk.finki.ukim.mk.lab.service.impl.BalloonServiceImpl;
import org.junit.Assert;
import org.junit.Before;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.MockitoAnnotations;
import org.mockito.junit.MockitoJUnitRunner;
import org.springframework.security.crypto.password.PasswordEncoder;

@RunWith(MockitoJUnitRunner.class)
public class SaveBalloonTest {


//    @Mock
//    private UserRepository userRepository;

    //    @Mock
//    private PasswordEncoder passwordEncoder;
    @Mock
    private BalloonRepository balloonRepository;

    @Mock
    private ManufacturerRepository manufacturerRepository;

    private BalloonService service;


    @Before
    public void init() {

        MockitoAnnotations.initMocks(this);
        Manufacturer manufacturer = new Manufacturer("M1", "USA", "Address1");
        Balloon balloon = new Balloon("name","desc",manufacturer);

        Mockito.when(this.manufacturerRepository.findById(1L)).thenReturn(java.util.Optional.of(manufacturer));
        Mockito.when(this.manufacturerRepository.findById(2L)).thenThrow(new ManufacturerNotFoundException(2L));


        Mockito.when(this.balloonRepository.findById(1L)).thenReturn(java.util.Optional.of(balloon));
        Mockito.when(this.balloonRepository.findById(2L)).thenReturn(null);
        Mockito.when(this.balloonRepository.save(Mockito.any(Balloon.class))).thenReturn(balloon);

        this.service = Mockito.spy(new BalloonServiceImpl(this.balloonRepository, this.manufacturerRepository));
    }

    @Test
    public void testManufacturerExist() {
        Long manufacturerId = 2L;
//        Manufacturer manufacturer = this.manufacturerRepository.findById(manufacturerId).orElse(null);
        Assert.assertThrows("ManufacturerNotFoundException expected",
                ManufacturerNotFoundException.class,
                () -> this.service.save(1L, "balloon", "desc", manufacturerId));
        Mockito.verify(this.service).save(1L, "balloon", "desc", manufacturerId);

    }

//    @Test
//    public void testSuccessSave() {
//
//        Balloon balloon = this.service.save(1L,"name","desc",1L);
//
//        Mockito.verify(this.service).save(1L, "name", "desc", 1L);
//
//
//        Assert.assertNotNull("Balloon is null", balloon);
//        Assert.assertEquals("name do not mach", "name", balloon.getName());
////        Assert.assertEquals("role do not mach", Role.ROLE_USER, user.getRole());
//        Assert.assertEquals("surename do not mach", "surename", balloon.getDescription());
//        Assert.assertEquals("password do not mach", "password", balloon.getPassword());
//        Assert.assertEquals("username do not mach", "username", user.getUsername());
//    }


//    @Test
//    public void testNullUsername() {
//        Assert.assertThrows("InvalidArgumentException expected",
//                InvalidUsernameOrPasswordException.class,
//                () -> this.service.register(null, "password", "password", "name", "surename", Role.ROLE_USER));
//        Mockito.verify(this.service).register(null, "password", "password", "name", "surename", Role.ROLE_USER);
//    }

}
