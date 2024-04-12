using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Server.Core.DTO.CategoryDTO;
using Web_Server.Core.Entity;
using Web_Server.Core.Interfaces;

namespace Web_Server.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<CategoryEntity> _categoryRepository;

        public CategoryService(IRepository<CategoryEntity> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateCategoryDTO createCategoryDTO)
        {
            var category = _mapper.Map<CategoryEntity>(createCategoryDTO);
            await _categoryRepository.InsertAsync(category);
            await _categoryRepository.SaveAsync();
        }

        public async Task DeleteCategoryByIDAsync(int id)
        {
            var categoryToDelete = await _categoryRepository.GetByIDAsync(id);
            if (categoryToDelete != null)
            {
                await _categoryRepository.DeleteAsync(categoryToDelete);
                await _categoryRepository.SaveAsync();
            }
        }

        public async Task EditAsync(EditCategoryDTO editCategoryDTO)
        {
            var category = _mapper.Map<CategoryEntity>(editCategoryDTO);
            await _categoryRepository.UpdateAsync(category);
            await _categoryRepository.SaveAsync();
        }

        public async Task<List<CategoryDTO>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAsync();
            return _mapper.Map<List<CategoryDTO>>(categories);

        }

        public async Task<CategoryDTO?> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIDAsync(id);
            return _mapper.Map<CategoryDTO>(category);
        }
    }
}
