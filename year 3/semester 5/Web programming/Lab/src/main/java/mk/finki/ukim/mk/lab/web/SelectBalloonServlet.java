package mk.finki.ukim.mk.lab.web;

import org.thymeleaf.context.WebContext;
import org.thymeleaf.spring5.SpringTemplateEngine;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;

@WebServlet(name = "SelectBalloonServlet", value = "/selectBalloon")
public class SelectBalloonServlet extends HttpServlet {
    private final SpringTemplateEngine springTemplateEngine;

    public SelectBalloonServlet(SpringTemplateEngine springTemplateEngine) {
        this.springTemplateEngine = springTemplateEngine;
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//        response.sendRedirect("");
        HttpSession session = request.getSession();
        String balloonColor = (String) session.getAttribute("color");
        WebContext context = new WebContext(request, response, request.getServletContext());
        context.setVariable("color", balloonColor);
        this.springTemplateEngine.process("selectBalloonSize.html", context, response.getWriter());
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//        String balloonColor = request.getParameter("color");
//        HttpSession session = request.getSession();
//        session.setAttribute("color",balloonColor);
//        WebContext context = new WebContext(request, response, request.getServletContext());
//        context.setVariable("color", balloonColor);
//        this.springTemplateEngine.process("selectBalloonSize.html", context, response.getWriter());

        String balloonSize = request.getParameter("size");
        HttpSession session = request.getSession();
        session.setAttribute("size",balloonSize);
        response.sendRedirect("/BalloonOrder.do");
    }
}
