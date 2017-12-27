using HighRiskComparator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Controllers
{
	[Route("api/[controller]")]
	public class PatientDataController : Controller
	{
		private readonly PatientDataContext _context;

		public PatientDataController(PatientDataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IEnumerable<PatientData> GetAll()
		{
			return _context.PatientDatas.ToList();
		}

		[HttpGet("{id}", Name = "GetPatientData")]
		public IActionResult GetById(long id)
		{
			var item = _context.PatientDatas.FirstOrDefault(t => t.Id == id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		[HttpPost]
		public IActionResult Create([FromBody] PatientData data)
		{
			if (data == null)
			{
				return BadRequest();
			}

			_context.PatientDatas.Add(data);
			_context.SaveChanges();

			return CreatedAtRoute("GetPatientData", new { id = data.Id }, data);
		}

		[HttpPut("{id}")]
		public IActionResult Update(long id, [FromBody] PatientData item)
		{
			if (item == null || item.Id != id)
			{
				return BadRequest();
			}

			var PatientData = _context.PatientDatas.FirstOrDefault(t => t.Id == id);
			if (PatientData == null)
			{
				return NotFound();
			}

			PatientData.Prenom = item.Prenom;
			PatientData.Nom = item.Nom;
			PatientData.DateDeNaissance = item.DateDeNaissance;
			PatientData.Genre = item.Genre;
			PatientData.Poids = item.Poids;
			PatientData.Taille = item.Taille;
			PatientData.HbA1c = item.HbA1c;
			PatientData.CholesterolTotal = item.CholesterolTotal;
			PatientData.CholesterolHdl = item.CholesterolHdl;
			PatientData.Pss = item.Pss;
			PatientData.ConsommationTabagique = item.ConsommationTabagique;

			_context.PatientDatas.Update(PatientData);
			_context.SaveChanges();
			return new NoContentResult();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(long id)
		{
			var PatientData = _context.PatientDatas.FirstOrDefault(t => t.Id == id);
			if (PatientData == null)
			{
				return NotFound();
			}

			_context.PatientDatas.Remove(PatientData);
			_context.SaveChanges();
			return new NoContentResult();
		}

	}
}