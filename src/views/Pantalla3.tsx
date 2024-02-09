import React, { useState } from 'react';
import logo from './logo.svg';
import Slider from 'react-slick';
import 'react-datepicker/dist/react-datepicker.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button, Carousel, Col, Container, Form, FormControl, InputGroup, Nav, Navbar, Row, Table } from 'react-bootstrap';
import DatePicker from 'react-datepicker';
// Import the necessary styles
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";

// Import Bootstrap and your custom CSS
import 'bootstrap/dist/css/bootstrap.min.css';
import '../components/App.css';
import { MyChart } from '../components/data';

function Pantalla3() {
    const [startDate, setStartDate] = useState(new Date());
    const [endDate, setEndDate] = useState(new Date());
  


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
          <h2 style={{display:'flex', justifyContent:"flex-start", marginLeft:"90px", marginTop:"20px"}}>Editar datos</h2>
          <div style={{ marginLeft: "90px",marginTop: "50px", display: 'flex', justifyContent:'flex-start'}}>
        <Form.Label htmlFor="selectEntidad" className="me-2">Entidad</Form.Label>
        <Form.Select id="selectEntidad" className="me-2" style={{ display: 'inline-block', width: 'auto', marginLeft:"50px" }}>
          <option>Select</option>
       </Form.Select>



      </div>
        
      <div style={{ display: 'flex',  padding: '20px', marginLeft:"70px"}}>
      <p style={{marginRight:"10px", marginTop:"5px"}}>Periodo</p>
      <div style={{ border:"1px solid black", display: 'flex', padding: '5px'}}>
      
        <Form.Group style={{ marginLeft:"30px"}}>
          <Form.Label style={{marginRight:"10px"}}>De: </Form.Label>
          <DatePicker selected={startDate} onChange={date => date && setStartDate(date)} />        </Form.Group>
     
        <Form.Group>
          <Form.Label style={{marginRight:"10px", marginLeft:"30px", }}>Hasta: </Form.Label>
          <DatePicker selected={endDate} onChange={date => date && setEndDate(date)} />        </Form.Group>
   </div>
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




export default Pantalla3;