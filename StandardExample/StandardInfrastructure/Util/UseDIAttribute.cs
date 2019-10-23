using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardInfrastructure.Util
{
    [AttributeUsage(AttributeTargets.Class,Inherited =false)]
    public class UseDIAttribute:Attribute
    {
        /// <summary>
        /// 依赖注入的目标类型
        /// </summary>
        private List<Type> _targetTypes = new List<Type>();
        private ServiceLifetime _lifeTime;

        public UseDIAttribute(ServiceLifetime lifeTime, params Type[] targetTypes)
        {
            foreach (var item in targetTypes)
            {
                _targetTypes.Add(item);
            }
            this._lifeTime = lifeTime;
        }
        /// <summary>
        /// 获取所有目标类型
        /// </summary>
        /// <returns></returns>
        public List<Type> GetTargetTypes()
        {
            return _targetTypes;
        }
        /// <summary>
        /// 获取声明周期
        /// </summary>
        public ServiceLifetime LifeTime
        {
            get { return this._lifeTime; }
        }

    }
}
