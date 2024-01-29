import React from 'react';
import logo from './logo.svg';
import './App.css';
import Slider from 'react-slick';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button, Carousel, Form, FormControl, InputGroup, Nav, Navbar, Table } from 'react-bootstrap';

// Import the necessary styles
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";

// Import Bootstrap and your custom CSS
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

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
          <h2 style={{display:'flex', justifyContent:"flex-start", marginLeft:"50px", marginTop:"20px"}}>Carga de datos</h2>
          <div style={{ marginLeft: "50px",marginTop: "50px", display: 'flex', justifyContent:'flex-start'}}>
        <Form.Label htmlFor="selectEntidad" className="me-2">Entidad</Form.Label>
        <Form.Select id="selectEntidad" className="me-2" style={{ display: 'inline-block', width: 'auto', marginLeft:"50px" }}>
          <option>Select</option>
          {/* Add more options here as needed */}
        </Form.Select>



      </div>
        
      <div style={{ display: 'flex', alignItems: 'center', padding: '10px' }}>
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
          {/* Here you can map through your data and create table rows */}
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td></td> {/* Empty cells for demonstration */}
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
          {/* Repeat the empty row as needed */}
          {/* ... */}
        </tbody>
      </Table>
        
        
        
    </div>
      );
    }



export default Pantalla2;