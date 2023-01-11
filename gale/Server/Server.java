/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package forza4;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.SocketTimeoutException;
import java.util.Scanner;

/**
 *
 * @author Erli
 */
public class Server {
    
    public int timeOut = 60;
    public boolean connected = false;
    private PrintWriter output;
    private Scanner input;
    private ServerSocket sersock;

    public Server(int port) throws IOException {
        try {
        sersock = new ServerSocket(port);        
        sersock.setSoTimeout(timeOut * 1000);
        System.out.println("Server  ready");
        Socket sock = sersock.accept();
        OutputStream ostream = sock.getOutputStream();
        output = new PrintWriter(ostream, true);
        InputStream istream = sock.getInputStream();
        input = new Scanner(istream);
        connected = true;
        sersock.close();
        }
        catch (SocketTimeoutException ex) {
            sersock.close();
            connected = false;
        }
    }
    public String receive() throws IOException {
        if (connected = true) return input.nextLine();
        return null;
    }
    public void send(String text) {
        if (connected == false) return;
        output.println(text);
        output.flush();
    }
    public void close() {
        input.close();
        output.close();
    }
}