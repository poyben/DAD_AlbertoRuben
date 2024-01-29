import React from 'react';
import logo from './logo.svg';
import './App.css';
import Slider from 'react-slick';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button, Carousel, Form, FormControl, InputGroup, Nav, Navbar } from 'react-bootstrap';

// Import the necessary styles
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";

// Import Bootstrap and your custom CSS
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

import grafico1 from './img/grafico1.png';
import grafico2 from './img/grafico2.png';
import grafico3 from './img/grafico3.jpg';
import Pantalla2 from './components/Pantalla2';


function App() {



    return (
      
        
        <Pantalla2/>
        
        /*
        <div className="App">
          <Navbar bg="light" expand="lg" className="justify-content-between">
            <Nav className="container-fluid">
              <Nav.Link href="#archivo">Archivo</Nav.Link>
              <Nav.Link href="#edicion">Edición</Nav.Link>
              <Nav.Link href="#datos">Datos</Nav.Link>
              <Nav.Link href="#analisis">Análisis</Nav.Link>
              <Nav.Link href="#configuracion">Configuración</Nav.Link>
            </Nav>
          </Navbar>
          <h2 style={{display:'flex', justifyContent:"flex-start", marginLeft:"50px", marginTop:"20px"}}>Previsión</h2>
          
          <div className="radio-toolbar" style={{ marginLeft: "50px", marginTop: "10px" }}>
        <Form>
          <div className="mb-3" style={{display:'flex', justifyContent:'flex-start'}}>
            <Form.Check 
              inline
              type="radio"
              label="Vista"
              name="viewOptions"
              id="radioSemana"
            />
             <div className="radio-toolbar" style={{ marginLeft: "50px" }}>
        <Form>
          <div className="mb-3">
            <Form.Check 
              inline
              type="radio"
              label="Semana"
              name="viewOptions"
              id="radioSemana"
            />
            <Form.Check 
              inline
              type="radio"
              label="Mes"
              name="viewOptions"
              id="radioMes"
            />
            <Form.Check 
              inline
              type="radio"
              label="Año"
              name="viewOptions"
              id="radioAno"
            />
            <Form.Check 
              inline
              type="radio"
              label="Select"
              name="viewOptions"
              id="radioSelect"
            />
          </div>
<div>
          {/* Periodo: Date Range Picker 
          <InputGroup className="mb-3">
            <InputGroup.Text>De</InputGroup.Text>
            <FormControl type="date" />
            <InputGroup.Text>Hasta</InputGroup.Text>
            <FormControl type="date" />
            <Button variant="outline-secondary">Visualiza</Button>
          </InputGroup>
          </div>
        </Form>
      </div>
      
            <Form.Check 
              inline
              type="radio"
              label="Periodo"
              name="viewOptions"
              id="radioMes"
            />

            </div>
            </Form></div>

         
          
          <div className="carousel-container">
            <Carousel>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src={grafico1}
                  alt="First slide"
                />
              </Carousel.Item>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src={grafico2}
                  alt="Second slide"
                />
              </Carousel.Item>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src={grafico3}
                  alt="Third slide"
                />
              </Carousel.Item>
            </Carousel>
          </div>
    </div>*/
    
      );
    }



export default App;