<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EntradaForm.aspx.cs" Inherits="VISTA.EntradaForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="EntradaForm.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/servicios/wsEntradas.asmx" />
            </Services>
        </asp:ScriptManager>
    <div class="container" style="margin-top:3%">
          <div class="row">
            <div class="col">
                <div class="form-group">                            
                    <input type="number" oninput="listener()" class="form-control" id="txtCodigo" aria-describedby="emailHelp" placeholder="Codigo del producto"/>
                </div>
                <div class="form-group">                            
                    <input type="number" placeholder="Cantidad" class="form-control" id="txtCantidad" aria-describedby="emailHelp"/>
                </div>
                <div class="form-group">                            
                    <input type="number" class="form-control" id="txtPrecioUnitario" aria-describedby="emailHelp" placeholder="Precio Unitario"/>
                </div>
                <div class="form-group">                            
                    <input type="text" class="form-control" name="txtFecha" id="txtFecha" aria-describedby="emailHelp" disabled="true"/>
                </div>
                <div class="col" style="text-align:center">
              <button type="button" class="btn btn-primary" style="width:120px; font-weight:500" onclick="guardar()">Agregar</button>
            </div>
            </div>
            <div class="col">
              <table  id="example" class="table table-striped table-bordered small" style="margin: 0 auto; width:90%" >  
              </table>  
            </div>
          </div>                   
          <div class="row" style="margin-top:1%">
            <table class="table table-hover">
              <thead>
                <tr>
                  <th scope="col">CodigoProducto</th>
                  <th scope="col">Cantidad</th>
                  <th scope="col">PrecioUitario</th>
                  <th scope="col">Fecha</th>
                  <th scope="col">Empleado</th>
                </tr>
              </thead>
              <tbody id="tblProducto">                           
              </tbody>
            </table>
          </div>        
        </div>        
    <div  class="container">
            <div class="row" style="margin-top:5%">
              <div class="col">              
              </div>
               <div class="col" style="text-align:center">               
                 <button type="button" class="btn btn-info" style="width:120px; font-weight:500">Registrar</button>
                   <button type="button" class="btn btn-danger" style="width:120px;font-weight:500" >Cancelar</button>
             </div>
             <div class="col">              
             </div>
              </div>
        </div>    
</asp:Content>
