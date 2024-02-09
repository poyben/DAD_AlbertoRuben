import React from 'react';
import logo from './logo.svg';
import Slider from 'react-slick';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button, Carousel, Col, Container, Form, FormControl, InputGroup, Nav, Navbar, Row, Table } from 'react-bootstrap';

// Import the necessary styles
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";

// Import Bootstrap and your custom CSS
import 'bootstrap/dist/css/bootstrap.min.css';
import '../components/App.css';
import { MyChart } from '../components/data';

function Pantalla2() {



    return (
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
          <h2 style={{display:'flex', justifyContent:"flex-start", marginLeft:"90px", marginTop:"20px"}}>Carga de datos</h2>
          <div style={{ marginLeft: "90px",marginTop: "50px", display: 'flex', justifyContent:'flex-start'}}>
        <Form.Label htmlFor="selectEntidad" className="me-2">Entidad</Form.Label>
        <Form.Select id="selectEntidad" className="me-2" style={{ display: 'inline-block', width: 'auto', marginLeft:"50px" }}>
          <option>Select</option>
       </Form.Select>



      </div>
        
      <div style={{ display: 'flex', alignItems: 'center', padding: '20px', marginLeft:"50px" }}>
        <Form.Check 
          type="radio"
          label="Fichero"
          name="options"
          id="option1"
          style={{ marginRight: '10px' }}
        />
        <InputGroup style={{ marginRight: '10px', maxWidth: '200px' }}>
          <Form.Control
            placeholder="Search"
            aria-label="Search"
          />
          <Button variant="outline-secondary" id="button-addon2">
            Cargar
          </Button>
        </InputGroup>
        <Form.Check 
          type="radio"
          label="Manual"
          name="options"
          id="option2"
          style={{ marginLeft: '10px' }}
        />
      </div>

<Container style={{margin:"50px"}}>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>Fecha</th>
            <th>Concepto</th>
            <th>Importe</th>
            <th>Grupo</th>
            <th>Periodo</th>
            <th>Persona</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td></td> 
           <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> 
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> 
        <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td>
           <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> 
          <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> 
       <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> 
       <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> 
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
       </tbody>
      </Table>
      </Container>
      <button type="button" className="btn btn-outline-secondary" style={{marginLeft:"500px"}}>Guardar</button>
        
        
        
    </div>
      );
    }




export default Pantalla2;