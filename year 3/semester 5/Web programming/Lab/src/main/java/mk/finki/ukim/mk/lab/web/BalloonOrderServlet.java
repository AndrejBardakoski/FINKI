package mk.finki.ukim.mk.lab.web;

import mk.finki.ukim.mk.lab.model.Order;
import mk.finki.ukim.mk.lab.service.OrderService;
import org.thymeleaf.context.WebContext;
import org.thymeleaf.spring5.SpringTemplateEngine;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;

@WebServlet(name = "BalloonOrderServlet", value = "/BalloonOrder.do")
public class BalloonOrderServlet extends HttpServlet {
    private final SpringTemplateEngine springTemplateEngine;
    private final OrderService orderService;

    public BalloonOrderServlet(SpringTemplateEngine springTemplateEngine, OrderService orderService) {
        this.springTemplateEngine = springTemplateEngine;
        this.orderService = orderService;
    }

//    public BalloonOrderServlet(SpringTemplateEngine springTemplateEngine) {
//        this.springTemplateEngine = springTemplateEngine;
//    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//        response.sendRedirect("");

        HttpSession session = request.getSession();
        String balloonColor = (String) session.getAttribute("color");
        String balloonSize = (String) session.getAttribute("size");
        WebContext context = new WebContext(request, response, request.getServletContext());
        context.setVariable("color", balloonColor);
        context.setVariable("size", balloonSize);
        this.springTemplateEngine.process("deliveryInfo.html", context, response.getWriter());
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//        String balloonSize = request.getParameter("size");
//        HttpSession session = request.getSession();
//        session.setAttribute("size",balloonSize);
//        String balloonColor = (String) session.getAttribute("color");
//        WebContext context = new WebContext(request, response, request.getServletContext());
//        context.setVariable("color", balloonColor);
//        context.setVariable("size", balloonSize);
//        this.springTemplateEngine.process("deliveryInfo.html", context, response.getWriter());

        String clientName = request.getParameter("clientName");
        String address = request.getParameter("clientAddress");
        HttpSession session = request.getSession();
        String color = (String) session.getAttribute("color");
        String size = (String) session.getAttribute("size");
        Order order = orderService.placeOrder(color,size,clientName,address);
        session.setAttribute("order", order);
        response.sendRedirect("/ConfirmationInfo");
    }
}
